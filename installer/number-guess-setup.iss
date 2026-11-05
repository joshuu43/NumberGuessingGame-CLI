
[Setup]
AppId={{A7D92F10-8E21-4D45-9B31-123456789ABC}
AppName=NumberGuessingGame CLI
AppVersion=1.0.0
AppPublisher=Joshuu43
DefaultDirName={localappdata}\Programs\NumberGuessingGame
DefaultGroupName=NumberGuessingGame CLI
OutputDir=output
OutputBaseFilename=number-guess-setup
Compression=lzma
SolidCompression=yes
WizardStyle=modern
ChangesEnvironment=yes
PrivilegesRequired=lowest

[Files]
Source: "..\bin\Release\net10.0\win-x64\publish\number-guess.exe"; DestDir: "{app}"; Flags: ignoreversion

[Icons]
Name: "{group}\NumberGuessingGame CLI"; Filename: "{app}\number-guess.exe"; Parameters: "--help"

[Code]
function PathContains(PathValue, Entry: string): Boolean;
begin
  Result := Pos(';' + LowerCase(Entry) + ';',
    ';' + LowerCase(PathValue) + ';') > 0;
end;

procedure CurStepChanged(CurStep: TSetupStep);
var
  UserPath: string;
begin
  if CurStep = ssPostInstall then
  begin
    if not RegQueryStringValue(HKEY_CURRENT_USER,
      'Environment', 'Path', UserPath) then
      UserPath := '';

    if not PathContains(UserPath, ExpandConstant('{app}')) then
    begin
      if UserPath <> '' then
        UserPath := UserPath + ';';

      UserPath := UserPath + ExpandConstant('{app}');

      RegWriteExpandStringValue(HKEY_CURRENT_USER,
        'Environment', 'Path', UserPath);
    end;
  end;
end;

procedure RemovePathEntry(var UserPath: string; Entry: string);
var
  NewPath, CurrentEntry: string;
  I: Integer;
begin
  NewPath := '';
  CurrentEntry := '';

  for I := 1 to Length(UserPath) + 1 do
  begin
    if (I > Length(UserPath)) or (UserPath[I] = ';') then
    begin
      if (Trim(CurrentEntry) <> '') and
         (CompareText(Trim(CurrentEntry), Entry) <> 0) then
      begin
        if NewPath <> '' then
          NewPath := NewPath + ';';

        NewPath := NewPath + Trim(CurrentEntry);
      end;

      CurrentEntry := '';
    end
    else
      CurrentEntry := CurrentEntry + UserPath[I];
  end;

  UserPath := NewPath;
end;

procedure CurUninstallStepChanged(CurUninstallStep: TUninstallStep);
var
  UserPath, Entry: string;
begin
  if CurUninstallStep = usUninstall then
  begin
    if RegQueryStringValue(
      HKEY_CURRENT_USER,
      'Environment',
      'Path',
      UserPath) then
    begin
      Entry := ExpandConstant('{app}');

      RemovePathEntry(UserPath, Entry);

      RegWriteExpandStringValue(
        HKEY_CURRENT_USER,
        'Environment',
        'Path',
        UserPath);
    end;
  end;
end;

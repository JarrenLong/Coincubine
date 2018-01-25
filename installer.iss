; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Coincubine"
#define MyAppVersion "1.0"
#define MyAppPublisher "Books N' Bytes, Inc."
#define MyAppURL "https://www.booksnbytes.net"
#define MyAppExeName "Coincubine.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{591FFBC5-E9B5-4960-A249-15E908883D50}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DisableDirPage=yes
DisableProgramGroupPage=yes
OutputBaseFilename=setup-Coincubine_{#MyAppVersion}
Compression=lzma
SolidCompression=yes
PrivilegesRequired=admin

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Files]
Source: ".\bin\Debug\NET45\Coincubine.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: ".\bin\Debug\NET45\LongTech.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: ".\bin\Debug\NET45\LongTech.Portable.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: ".\bin\Debug\NET45\LongTech.UI.Controls.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: ".\bin\Debug\NET45\LongTech.UI.Theme.dll"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{commonprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commonstartup}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent


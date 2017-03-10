; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "WinHue 3"
#define MyAppVersion "BETA 27"
#define MyAppPublisher "Pascal Pharand"
#define MyAppURL "https://hyrules.github.io/WinHue3/"
#define MyAppExeName "WinHue3.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{F16560B0-47D1-4122-A0A4-9104FDF62AC1}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DisableDirPage=false
DefaultGroupName={#MyAppName}
OutputBaseFilename={#MyAppName} {#MyAppVersion} Setup
Compression=lzma
SolidCompression=yes
PrivilegesRequired=admin
SetupIconFile="D:\Documents\Visual Studio 2015\Projects\WinHue3\WinHue3\icon.ico"
InfoBeforeFile="D:\Desktop\readme\WinHue\README.txt"

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "french"; MessagesFile: "compiler:Languages\French.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1

[Files]
Source: "D:\Documents\Visual Studio 2015\Projects\WinHue3\WinHue3\bin\Debug\*.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\Visual Studio 2015\Projects\WinHue3\WinHue3\bin\Debug\whc.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\Visual Studio 2015\Projects\WinHue3\WinHue3\bin\Debug\Xceed.Wpf.DataGrid.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\Visual Studio 2015\Projects\WinHue3\WinHue3\bin\Debug\WinHue3.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\Visual Studio 2015\Projects\WinHue3\WinHue3\bin\Debug\HueLib2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\Visual Studio 2015\Projects\WinHue3\WinHue3\bin\Debug\ManagedUPnP.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\Visual Studio 2015\Projects\WinHue3\WinHue3\bin\Debug\OpenHardwareMonitorLib.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\Visual Studio 2015\Projects\WinHue3\WinHue3\bin\Debug\NDesk.Options.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\Visual Studio 2015\Projects\WinHue3\WinHue3\bin\Debug\Newtonsoft.Json.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\Visual Studio 2015\Projects\WinHue3\WinHue3\bin\Debug\Xceed.Wpf.Toolkit.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\Visual Studio 2015\Projects\WinHue3\WinHue3\bin\Debug\log4net.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\Visual Studio 2015\Projects\WinHue3\WinHue3\bin\Debug\log4net.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\Visual Studio 2015\Projects\WinHue3\WinHue3\bin\Debug\System.Windows.Interactivity.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\Visual Studio 2015\Projects\WinHue3\WinHue3\bin\Debug\Hardcodet.Wpf.TaskbarNotification.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\Visual Studio 2015\Projects\WinHue3\WinHue3\bin\Debug\Microsoft.Expression.Interactions.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\Visual Studio 2015\Projects\WinHue3\WinHue3\bin\Debug\fr\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "D:\Documents\Visual Studio 2015\Projects\WinHue3\WinHue3\bin\Debug\lights\*"; DestDir: "{app}\lights"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "D:\Documents\Visual Studio 2015\Projects\WinHue3\WinHue3\bin\Debug\naudio.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\Visual Studio 2015\Projects\WinHue3\WinHue3\bin\Debug\prism.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\Visual Studio 2015\Projects\WinHue3\WinHue3\bin\Debug\prism.wpf.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\Visual Studio 2015\Projects\WinHue3\WinHue3\bin\Debug\procdump.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\Visual Studio 2015\Projects\WinHue3\WinHue3\bin\Debug\Xceed.Wpf.AvalonDock.dll"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\procdump"; Filename: "{app}\procdump.exe"; Parameters : "-e -w -ma WinHue3.exe {localappdata}\WinHue3"
Name: "{group}\{cm:ProgramOnTheWeb,{#MyAppName}}"; Filename: "{#MyAppURL}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent runascurrentuser

[Code]
function IsDotNetDetected(version: string; service: cardinal): boolean;
// Indicates whether the specified version and service pack of the .NET Framework is installed.
//
// version -- Specify one of these strings for the required .NET Framework version:
//    'v1.1.4322'     .NET Framework 1.1
//    'v2.0.50727'    .NET Framework 2.0
//    'v3.0'          .NET Framework 3.0
//    'v3.5'          .NET Framework 3.5
//    'v4\Client'     .NET Framework 4.0 Client Profile
//    'v4\Full'       .NET Framework 4.0 Full Installation
//    'v4.5'          .NET Framework 4.5
//    'v4.5.1'        .NET Framework 4.5.1 
//
// service -- Specify any non-negative integer for the required service pack level:
//    0               No service packs required
//    1, 2, etc.      Service pack 1, 2, etc. required
var
    key: string;
    install, release, serviceCount: cardinal;
    check45, check451, success: boolean;
begin
    // .NET 4.5 installs as update to .NET 4.0 Full
    if version = 'v4.5' then begin
        version := 'v4\Full';
        check45 := true;
        check451 := false;
    end else if version = 'v4.5.1' then begin
        version := 'v4\Full';
        check451 := true;
        check45 := false;
    end else begin
        check45 := false;
        check451 := false;
    end;

    // installation key group for all .NET versions
    key := 'SOFTWARE\Microsoft\NET Framework Setup\NDP\' + version;

    // .NET 3.0 uses value InstallSuccess in subkey Setup
    if Pos('v3.0', version) = 1 then begin
        success := RegQueryDWordValue(HKLM, key + '\Setup', 'InstallSuccess', install);
    end else begin
        success := RegQueryDWordValue(HKLM, key, 'Install', install);
    end;

    // .NET 4.0/4.5 uses value Servicing instead of SP
    if Pos('v4', version) = 1 then begin
        success := success and RegQueryDWordValue(HKLM, key, 'Servicing', serviceCount);
    end else begin
        success := success and RegQueryDWordValue(HKLM, key, 'SP', serviceCount);
    end;

    // .NET 4.5 uses additional value Release
    if check45 then begin
        success := success and RegQueryDWordValue(HKLM, key, 'Release', release);
        success := success and (release = 378389);
    end;

    // .NET 4.5.1
    if check451 then begin
        success := success and RegQueryDWordValue(HKLM, key, 'Release', release);
        success := success and (release >= 378675);
    end;

    result := success and (install = 1) and (serviceCount >= service);
end;


function InitializeSetup(): Boolean;
begin
    if not IsDotNetDetected('v4.5.1', 0) then begin
        MsgBox('WinHue 3 requires Microsoft .NET Framework 4.5.1'#13#13
            'Please use Windows Update to install this version,'#13
            'and then re-run the WinHue 3 setup program.', mbInformation, MB_OK);
        result := false;
    end else
        result := true;
end;
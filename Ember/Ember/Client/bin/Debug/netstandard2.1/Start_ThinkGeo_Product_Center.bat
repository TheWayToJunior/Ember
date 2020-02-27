@ECHO OFF
ECHO Starting ThinkGeo Product Center...
ECHO.

:FindNetCore3Runtime
dotnet --info | findstr /L /I /C:"Microsoft.NETCore.App 3.0.0 "
IF ERRORLEVEL 1 (
    GOTO FindNetCore3SDK
)
IF NOT ERRORLEVEL 1 (
    GOTO LaunchProductCenter
)

:FindNetCore3SDK
dotnet --info | findstr /L /I /C:"3.0.100 "
IF ERRORLEVEL 1 (
    GOTO DotNetMissing
)
IF NOT ERRORLEVEL 1 (
    GOTO LaunchProductCenter
)

:LaunchProductCenter
ECHO.
REM ECHO Product Center is ready to roll.
START "ThinkGeo Product Center" ".\ThinkGeo.ProductCenter.exe"
GOTO End

:DotNetMissing
ECHO You must install the .NET Core 3.0 runtime or SDK
ECHO before starting ThinkGeo Product Center.
ECHO.
ECHO Download .NET Core 3.0 from:
ECHO https://dotnet.microsoft.com/download/dotnet-core/current
ECHO.
PAUSE

:End

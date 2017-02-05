@echo off
cd /d %~dp0

set outputDir=%cd%

"C:\Program Files (x86)\MSBuild\14.0\Bin\MSBuild.exe" ../Owen.Site.sln /p:Configuration=Release /t:Clean
"C:\Program Files (x86)\MSBuild\14.0\Bin\MSBuild.exe" ../Owen.Site.Host\Owen.Site.Host.csproj /p:Configuration=Release /t:Clean

"C:\Program Files (x86)\MSBuild\14.0\Bin\MSBuild.exe" ../Owen.Site.Host\Owen.Site.Host.csproj /p:Configuration=Release /t:Rebuild

xcopy /s ..\Owen.Site.Host\bin  %outputDir%\OutPut\

@pause 
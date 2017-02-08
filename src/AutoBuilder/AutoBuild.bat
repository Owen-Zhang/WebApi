@echo off
cd /d %~dp0

set outputDir=%cd%
set buildPath="C:\Program Files (x86)\MSBuild\14.0\Bin\MSBuild.exe"

::清除已生成的文件
%buildPath% ../Owen.Site.sln /p:Configuration=Release /t:Clean
%buildPath% ../Owen.Site.Host\Owen.Site.Host.csproj /p:Configuration=Release /t:Clean

::删除output下生成的临时文件
rd /s /q %outputDir%\OutPut\

::重新编译生成文件
%buildPath% ../Owen.Site.Host\Owen.Site.Host.csproj /p:Configuration=Release;OutDir=%outputDir%\OutPut\bin /t:Rebuild 

set binPath=%outputDir%\OutPut\bin

::删除bin下面的文件夹
for /f %%s in ('dir /s /a /b %binPath%') do (
	if exist %%s\ (rd /s /q %%s)
)

::复制数据访问相关的sql
xcopy /s ..\Owen.Site.Data.Service.Imp\Configuration  %outputDir%\OutPut\Configuration\

::复制host工程中的一些文件或者某些文件夹下面的所有文件(HostMustCopyFileList.txt在里面配制)
for /f %%i in (HostMustCopyFileList.txt) do (
	if exist ..\Owen.Site.Host\%%i\ (xcopy /s ..\Owen.Site.Host\%%i %outputDir%\OutPut\%%i\) else (xcopy /s ..\Owen.Site.Host\%%i %outputDir%\OutPut\)
)

@pause 
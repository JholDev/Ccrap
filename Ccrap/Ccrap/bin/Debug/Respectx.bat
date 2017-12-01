@echo off
SET /a VAR=0 
cd %~f0
:runthis
SET /a VAR=VAR+1
start Respect.vbs
IF %VAR%==10 goto :End
goto :runthis

:End 
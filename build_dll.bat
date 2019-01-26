@echo off
REM build dll
::remove the extension
set file=%~n1
csc %file%.cs /target:library /out:%file%.dll && echo %file%.dll was build succesfully!
IF %ERRORLEVEL% NEQ 0 (
  REM do something here to address the error
  echo Error while building %file%.cs!
)
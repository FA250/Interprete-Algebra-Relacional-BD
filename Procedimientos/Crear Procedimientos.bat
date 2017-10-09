for %%G in (*.sql) do sqlcmd /S FABIAN-PC /d bdproy1 -E -i"%%G"
pause
for /f "tokens=1-2 delims=," %%a in (download.txt) do (
cdnsp.py -r -g %%a-0
ren %%a\%%a.nsp "%%b.nsp"
if not exist Finished mkdir Finished
move %%a\"%%b.nsp" Finished\"%%b.nsp"
if not exist "Finished\%%b.nsp" echo %%b >> failed.txt
echo y|rmdir %%a /s
)
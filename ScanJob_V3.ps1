$files_IN = Get-ChildItem 'C:\program_files\Scan\IN' -Recurse | where {!$_.PsIsContainer}
$files_OUT = Get-ChildItem 'C:\program_files\Scan\OUT' -Recurse | where {!$_.PsIsContainer}  

 
# Target Filder where files should be moved to. The script will automatically create a folder for the year and month.
$targetPath_IN = '*Insert destination Folder here*'
$targetPath_OUT = '*Insert destination Folder here*'
#Directories for Archived files
$SourceIN = 'C:\program_files\Scan\Archive\IN\'
$SourceOUT = 'C:\program_files\Scan\Archive\OUT\'
#Cycle for moving files from IN Directory
foreach ($file in $files_IN)
{
$year = $file.LastWriteTime.Year.ToString()
$month = $file.LastWriteTime.Month.ToString()
# Fullmonth - converting number of month to actual month name
$fullmonth = Get-Date -Month $month -Format MMMM
$Directory = $targetPath_IN + "\" + $year + "\" + $fullmonth
$DirectoryArchive = $SourceIN + "\" + $year + "\" + $fullmonth
if (!(Test-Path $Directory))
{
New-Item $Directory -type directory
}
if (!(Test-Path $DirectoryArchive))
{
New-Item $DirectoryArchive -type directory
}
# Move File to new location
$file | Copy-Item -Destination $DirectoryArchive -Recurse
$file | Move-Item -Destination $Directory -Force
}
#Cycle for moving files from OUT Directory
foreach ($file in $files_OUT)
{
$year = $file.LastWriteTime.Year.ToString()
$month = $file.LastWriteTime.Month.ToString()
# Fullmonth - converting number of month to actual month name
$fullmonth = Get-Date -Month $month -Format MMMM
$Directory = $targetPath_OUT + "\" + $year + "\" + $fullmonth
$DirectoryArchive = $SourceOUT + "\" + $year + "\" + $fullmonth
if (!(Test-Path $Directory))
{
New-Item $Directory -type directory
}
if (!(Test-Path $DirectoryArchive))
{
New-Item $DirectoryArchive -type directory
}
# Move File to new location
$file | Copy-Item -Destination $DirectoryArchive -Recurse
$file | Move-Item -Destination $Directory -Force
}


$wsh = New-Object -ComObject WScript.Shell

while ($true) {
    $wsh.SendKeys('+{F15}')
    $time = Get-Random -Minimum 55 -Maximum 86
    Start-Sleep -Seconds $time
}

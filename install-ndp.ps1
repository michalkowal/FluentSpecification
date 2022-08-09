function devpack-installed ($version) {
  if (Get-ItemProperty -Path "HKLM:\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\*", "HKLM:\SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall\*" | Where {$_.DisplayName -eq "Microsoft .NET Framework $($version) Developer Pack"}) {
    return $true
  }
}

#needed for 4.5.2 which has different naming convention
function multitargetingpack-installed ($version) {
  if (Get-ItemProperty -Path "HKLM:\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\*", "HKLM:\SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall\*" | Where {$_.DisplayName -eq "Microsoft .NET Framework $($version) Multi-Targeting Pack"}) {
    return $true
  }
}

function install-devpack ($version, $location) {
  Write-Host ".NET Framework $($version) Developer Pack..." -ForegroundColor Cyan
  Write-Host "Downloading..."
  $exePath = "$env:TEMP\$($version)-devpack.exe"
  (New-Object Net.WebClient).DownloadFile($location, $exePath)
  Write-Host "Installing..."
  cmd /c start /wait "$exePath" /quiet /norestart
  Remove-Item $exePath -Force -ErrorAction Ignore
  Write-Host "Installed" -ForegroundColor Green
}

install-devpack -version "4.5.2" -location "https://download.microsoft.com/download/4/3/B/43B61315-B2CE-4F5B-9E32-34CCA07B2F0E/NDP452-KB2901951-x86-x64-DevPack.exe"
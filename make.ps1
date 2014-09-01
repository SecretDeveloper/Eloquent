param(
    $buildType = "Release"
)

function clean{
    # CLEAN
    write-host "Cleaning" -foregroundcolor:blue
    if(!(Test-Path "$basePath\src\BuildOutput\"))
    {
        mkdir "$basePath\src\BuildOutput\"
    }
    if(!(Test-Path "$logPath"))
    {
        mkdir "$logPath"
    }
    if(!(Test-Path "$basePath\src\TestOutput\"))
    {
        mkdir "$basePath\src\TestOutput\"
    }
    if(!(Test-Path "$basePath\src\Eloquent\TestResults\"))
    {
        mkdir "$basePath\src\Eloquent\TestResults\"
    }
    remove-item $basePath\src\BuildOutput\*.* -recurse
    remove-item $basePath\src\TestOutput\* -recurse
    remove-item $basePath\src\Eloquent\TestResults\* -recurse
    remove-item $logPath\* -recurse
    $lastResult = $true
}

function build{
    # BUILD
    write-host "Building"  -foregroundcolor:blue
    $msbuild = "c:\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild.exe"
    $solutionPath = "$basePath\src\Eloquent\Eloquent.sln"
    Invoke-expression "$msbuild $solutionPath /p:configuration=$buildType /t:Clean /t:Build /nologo > $logPath\LogBuild.log"
    $content = (Get-Content -Path "$logPath\LogBuild.log")
    $failedContent = ($content -match "Build FAILED.")
    $failedCount = $failedContent.Count
    if($failedCount -gt 0)
    {    
        Write-host "BUILDING FAILED!" -foregroundcolor:red
        $lastResult = $false
        exit
    }

    if($? -eq $False){
        Write-host "BUILD FAILED!"
        exit
    }
}

function test{
    # TESTING
    write-host "Testing"  -foregroundcolor:blue
    $trxPath = "$basePath\src\TestOutput\AllTest.trx"
    $resultFile="/resultsfile:$trxPath"

    $testDLLs = get-childitem -path "$basePath\src\TestOutput\*.*" -include "*Tests.dll"
     
    $fs = New-Object -ComObject Scripting.FileSystemObject
    $f = $fs.GetFile("C:\Program Files (x86)\Microsoft Visual Studio 11.0\Common7\IDE\mstest.exe")
    $mstestPath = $f.shortpath   
    $arguments = " /testcontainer:" + $testDLLs + " /TestSettings:$basePath\src\Eloquent\LocalTestRun.testsettings"

    Invoke-Expression "$mstestPath $resultFile $arguments > $logPath\LogTest.log"

    $content = (Get-Content -Path "$logPath\LogTest.log")
    $passedContent = ($content -match "Passed")
    if($passedContent.Count -eq 0)
    {    
        Write-host "TESTING FAILED!" -foregroundcolor:red
        $lastResult = $false
    }
    if($lastResult -eq $False){    
        exit
    }

    $failedContent = ($content -match "^Failed")
    $failedCount = $failedContent.Count
    if($failedCount -gt 0)
    {    
        Write-host "TESTING FAILED!" -foregroundcolor:red
        $lastResult = $false
    }
    Foreach ($line in $failedContent) 
    {
        write-host $line -foregroundcolor:red
    }
    if($lastResult -eq $False){    
        exit
    }
}

function document{
    # DOCUMENTING
    Write-Host "Documenting" -foregroundcolor:blue
    Invoke-expression "tdg -i '.\src\templates\README.template.md' -o './README.md'"
}

function deploy{
    # DEPLOYING
    write-host "Deploying" -foregroundcolor:blue
    zip a -tzip .\src\buildoutput\last.zip .\src\BuildOutput\*.* > $logPath\LogDeploy.log
}

$basePath = Get-Location
$logPath = "$basePath\src\logs"

if($buildType -eq "Release"){
    clean
    build
    test
    document
    deploy
}
else{
    clean
    build
    test
}

Write-Host Finished -foregroundcolor:blue
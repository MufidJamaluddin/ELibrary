dotnet test --logger "trx;LogFileName=TestResults.trx" ^
            --logger "xunit;LogFileName=TestResults.xml" ^
            --results-directory ./test_results/UnitTests ^
            /p:CollectCoverage=true ^	
	    /p:CoverletOutput=test_results\Coverage\ ^
	    /p:CoverletOutputFormat=cobertura ^
	    /p:Exclude="[xunit.*]*

tools\reportgenerator.exe ^
       "-reports:test_results\Coverage\coverage.cobertura.xml" ^
       "-targetdir:test_results\Coverage" ^
       -reporttypes:HTML;HTMLSummary

start test_result\Coverage\index.htm
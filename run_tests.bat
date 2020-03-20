cd ./tests/SmartLibrary.UnitTests

dotnet test /p:CollectCoverage=true ^
	    /p:CoverletOutputFormat=cobertura ^
	    /p:CoverletOutput=./../../test_results/UnitTests/ ^
	    /p:Exclude="[xunit.*]*

cd ./../../


cd ./tests/SmartLibrary.Web.IntegrationTests

dotnet test /p:CollectCoverage=true ^
	    /p:CoverletOutputFormat=cobertura ^
	    /p:CoverletOutput=./../../test_results/IntegrationTests/ ^
	    /p:Exclude="[xunit.*]*

cd ./../../


cd ./src/SmartLibrary.Web.FrontEnd

npm run test:ci

cd ./../../


tools\reportgenerator.exe ^
       "-reports:test_results\*Tests\*.xml" ^
       "-targetdir:test_results\Coverage" ^
       -reporttypes:HTML;HTMLSummary
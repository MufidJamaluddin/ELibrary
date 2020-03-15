var ncp = require("ncp");
var path = require("path");
var fs = require("fs");

const build_folder = 'build';
const dir_path = path.join(__dirname, 'build');

const target_folder = '../SmartLibrary.Web/wwwroot/';

/**
 * Copy File Hasil Build Reactjs
 * ke Proyek ASP.NET static files 
 */
function copy_file()
{
    console.log('Copy File CSS, JS, IMG, dan Media ke ASP.NET static files');
    ncp(build_folder + "/static", target_folder + "/static", callback);

    fs.readdir(dir_path, function(err, files){
        if(err)
        {
            console.error(err);
            console.log('Gagal Copy File!');
        }
        else
        {
            files.forEach(function(file)
            {
                if(file !== 'static')
                {
                    console.log('Copy File ' + file + ' ke "'+ target_folder +'"');
                    ncp(build_folder + '/' + file, target_folder + file, callback);
                }
            });
        }
    });
}

function callback(error)
{
    if(error) 
    {
        console.log(error);
        console.log('GAGAL Copy File ke "ujian_app/static"!');
    }
} 

copy_file();
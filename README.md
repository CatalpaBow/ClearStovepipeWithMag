# ClearStovepipeWithMag
![stovepipe](https://github.com/CatalpaBow/ClearStovepipeWithMag/assets/14165691/40773198-a9d1-4314-9b85-3e362e3ae99c)

You can now clear a stovepipe jam by chopping it with a magazine... 

This mod was created and inspired by this YouTube video.

AR Stovepipe Clearance - Tap/Rack can lead to double feed? WHY!!:https://youtu.be/tkrxNTWcvEc
3. When building in Debug mode, a `your_name.mod_name.dll.mdb` file will also be generated in the output folder. Copy this into your plugins folder as well for additional debugging details such as filenames and line numbers in stack traces.

## Including extra files
If you need to include additional files with your plugin (for example, an asset bundle) you can add the file to your project and open the properties dialog to change the 'Copy to output directory' option to 'Copy if newer'. It will then be included in your builds, however do note that when r2mm/TMM goes to install your mod it will flatten the file structure of your mod. This means that any files in a subfolder will be moved beside your plugin's dll, so watch out for that when loading the extra files.

## Sharing / Uploading to Thunderstore
This template comes with a build script that automatically makes a thunderstore package file that you can easily upload. Before uploading you will want to modify / replace the following files with your own:

* `README.md`: this file, this is the long description of your mod.
* `icon.png`: the icon for your mod on TS. Must be 256x256.
* `LICENSE`: you may remove this file if you don't need a license, or replace with your own license.
* `manifest.json`: most of the stuff here is filled out during a build but if you have additional dependencies on other Thunderstore mods you will place them here.
3. When building in Debug mode, a `your_name.mod_name.dll.mdb` file will also be generated in the output folder. Copy this into your plugins folder as well for additional debugging details such as filenames and line numbers in stack traces.

## Including extra files
If you need to include additional files with your plugin (for example, an asset bundle) you can add the file to your project and open the properties dialog to change the 'Copy to output directory' option to 'Copy if newer'. It will then be included in your builds, however do note that when r2mm/TMM goes to install your mod it will flatten the file structure of your mod. This means that any files in a subfolder will be moved beside your plugin's dll, so watch out for that when loading the extra files.

## Sharing / Uploading to Thunderstore
This template comes with a build script that automatically makes a thunderstore package file that you can easily upload. Before uploading you will want to modify / replace the following files with your own:

* `README.md`: this file, this is the long description of your mod.
* `icon.png`: the icon for your mod on TS. Must be 256x256.
* `LICENSE`: you may remove this file if you don't need a license, or replace with your own license.
* `manifest.json`: most of the stuff here is filled out during a build but if you have additional dependencies on other Thunderstore mods you will place them here.

With these files modified / replaced, do another build and your Thunderstore package will be output to `plugin/bin/[Debug|Release]/net32/your_name.mod_name.zip`. This file can be uploaded straight to Thunderstore or imported as a local mod in r2mm/TMM.

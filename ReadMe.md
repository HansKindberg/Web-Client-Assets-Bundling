# Web-Client-Assets-Bundling

Bundling client-assets for a web-application. Using gulp and rollup.

This is a solution for showing one way to handle client-assets for a web-application. That is:
- One bundled css-file (unminified/minified)
- One svg-sprite
- One bundled javascript-file (unminified/minified)

It is handled with npm, gulp, rollup and the "Task Runner Explorer".

The solution is a razor-pages-application, with some diagnostics pages. But that is not important. The important files and folders are:
- wwwroot
- Scripts
- Style
- gulpfile.js
- package.json
- tsconfig.json

Initially install all npm-packages by using any of the following:
- the install-task (package.json) in "Task Runner Explorer"
- right-clicking the package.json -> Restore Packages

Make changes to any of the following:
- Scripts/Site.ts
- Style/Icons (add an svg)
- Style/Images (add an image)
- Style/Site.scss

then run the "default" task in the "Task Runner Explorer" and you get the result under the wwwroot-folder.
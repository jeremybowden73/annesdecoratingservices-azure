/// <binding AfterBuild='sass' />
var gulp = require("gulp"),
    fs = require("fs"),
    //less = require("gulp-less"),
    sass = require("gulp-sass");

// other content removed

gulp.task("sass", function () {
    return gulp.src('sass/style.scss')
        .pipe(sass())
        .pipe(gulp.dest('wwwroot/css'));
});

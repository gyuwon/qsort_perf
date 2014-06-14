/* jshint node: true */

var srand = require('srand');

function isSorted(a) {
  var n = a.length;
  for (var i = 1; i < n; i++) {
    if (a[i - 1] > a[i]) {
      return false;
    }
  }
  return true;
}

(function () {
  srand.seed(1);
  var n = 1000000, a = new Array(n);
  for (var i = 0; i < n; i++) {
    a[i] = srand.rand();
  }
  var begin = new Date();
  a.sort(function (x, y) { return x - y; });
  var elapsed = (new Date() - begin) / 1000;
  if (isSorted(a) !== true) {
    throw 'Not sorted!';
  }
  console.log(elapsed + ' sec elapsed.');
})();


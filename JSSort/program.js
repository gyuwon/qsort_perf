/* jshint node: true */

var srand = require('srand');

function quicksort(a, start, end) {
  if (end - start < 2) {
    return;
  }
  var p = a[(start + (end - start) / 2) >> 0];
  var l = start;
  var r = end - 1;
  while (l <= r) {
    if (a[l] < p) {
      ++l;
      continue;
    }
    if (a[r] > p) {
      --r;
      continue;
    }
    var t = a[l];
    a[l] = a[r];
    a[r] = t;
    ++l;
    --r;
  }
  quicksort(a, start, r + 1);
  quicksort(a, r + 1, end);
}

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
  var n = 1000000, a = new Array(n), builtin = false, begin;
  for (var i = 0; i < n; i++) {
    a[i] = srand.rand();
  }
  process.argv.forEach(function (arg) {
    if (arg === 'builtin') {
      builtin = true;
	  return false;
    }
  });
  if (builtin) {
    begin = new Date();
    a.sort(function (x, y) { return x - y; });
  }
  else {
    begin = new Date();
    quicksort(a, 0, n);
  }
  var elapsed = (new Date() - begin) / 1000;
  if (isSorted(a) !== true) {
    throw 'Not sorted!';
  }
  console.log(elapsed + ' sec elapsed.');
})();


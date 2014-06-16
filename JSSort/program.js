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

function quicksortThreeway(a, start, end) {
    if (end - start < 2) {
      return;
    }
    var p = a[start];
    var l = start;
    var m = l + 1;
    var i = m;
    while (i < end) {
      if (a[i] < p) {
        a[l++] = a[i];
        a[i] = a[m];
        a[m++] = p;
      }
      else if (a[i] == p) {
        a[i] = a[m];
        a[m++] = p;
      }
      ++i;
    }
    quicksortThreeway(a, start, l);
    quicksortThreeway(a, m, end);
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

function run(a, seed, threeway, builtin) {
  srand.seed(seed);
  var n = a.length
  for (var i = 0; i < n; i++) {
    a[i] = srand.rand();
  }
  var begin;
  if (threeway) {
    begin = new Date();
    quicksortThreeway(a, 0, n);
  }
  else if (builtin) {
    begin = new Date();
    a.sort(function (x, y) { return x - y; });
  }
  else {
    begin = new Date();
    quicksort(a, 0, n);
  }
  var elapsed = new Date() - begin;
  if (isSorted(a) !== true) {
    throw 'Not sorted!';
  }
  return elapsed;
}

(function () {
  var n = 1000000, a = new Array(n), threeway = false, builtin = false;
  process.argv.forEach(function (arg) {
    if (arg === 'threeway') {
      threeway = true;
      return false;
    }
    else if (arg === 'builtin') {
      builtin = true;
      return false;
    }
  });
  var iter = 12, trim = 1, elapsed = new Array(iter), sum = 0, i;
  for (i = 0; i < iter; i++) {
    elapsed[i] = run(a, (Math.random() * 65536) >> 0, builtin);
  }
  elapsed.sort(function (x, y) { return x - y; });
  for (i = trim; i < iter - trim * 2; i++) {
    sum += elapsed[i];
  }
  var mean = sum / (iter - trim * 2);
  console.log(mean + ' ms elapsed.');
})();


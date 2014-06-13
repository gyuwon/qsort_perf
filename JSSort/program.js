var srand = require('srand');

function quicksort(a, start, end) {
}

srand.seed(1);
var n = 10
  , a = new Array(n);
for (var i = 0; i < n; i++) {
  a[i] = srand.rand();
  console.log(a[i]);
}
quicksort(a, 0, n);


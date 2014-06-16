import java.lang.IllegalStateException;
import java.util.Arrays;
import java.util.Random;

public final class Program {
  public static void main(String[] args) {
    final int n = 1000000;
    int[] a = new int[n];
    boolean threeway = false, builtin = false;
    for (int i = 0; i < args.length; i++) {
      if ("threeway".equals(args[i])) {
        threeway = true;
        break;
      }
      else if ("builtin".equals(args[i])) {
        builtin = true;
	break;
      }
    }
    final int iter = 12;
    final int trim = 1;
    long[] elapsed = new long[iter];
    for (int i = 0; i < iter; i++) {
      elapsed[i] = run(a, new Random().nextInt(), threeway, builtin);
    }
    Arrays.sort(elapsed);
    long sum = 0;
    for (int i = trim; i < iter - trim * 2; i++) {
      sum += elapsed[i];
    }
    double mean = ((double)sum) / (iter - trim * 2);
    System.out.println(mean + " ms elapsed.");
  }

  static long run(int[] a, long seed, boolean threeway, boolean builtin) {
    Random random = new Random(seed);
    for (int i = 0; i < a.length; i++) {
      a[i] = random.nextInt(Short.MAX_VALUE + 1);
    }
    long begin;
    if (threeway) {
      begin = System.currentTimeMillis();
      quicksortThreeway(a, 0, a.length);
    }
    else if (builtin) {
      begin = System.currentTimeMillis();
      Arrays.sort(a);
    }
    else {
      begin = System.currentTimeMillis();
      quicksort(a, 0, a.length);
    }
    long elapsed = System.currentTimeMillis() - begin;
    if (isSorted(a) == false) {
      throw new IllegalStateException("Not sorted!");
    }
    return elapsed;
  }

  static void quicksort(int[] a, int start, int end) {
    if (end - start < 2) {
      return;
    }
    int p = a[start + (end - start) / 2];
    int l = start;
    int r = end - 1;
    while (l <= r) {
      if (a[l] < p) {
        ++l;
	continue;
      }
      if (a[r] > p) {
        --r;
	continue;
      }
      int t = a[l];
      a[l] = a[r];
      a[r] = t;
      ++l;
      --r;
    }
    quicksort(a, start, r + 1);
    quicksort(a, r + 1, end);
  }

  static void quicksortThreeway(int[] a, int start, int end) {
    if (end - start < 2) {
      return;
    }
    int p = a[start];
    int l = start;
    int m = l + 1;
    int i = m;
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

  static boolean isSorted(int[] array) {
    for (int i = 1; i < array.length; i++) {
      if (array[i - 1] > array[i]) {
        return false;
      }
    }
    return true;
  }
}


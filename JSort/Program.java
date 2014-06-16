import java.lang.IllegalStateException;
import java.util.Arrays;
import java.util.Random;

public final class Program {
  public static void main(String[] args) {
    final int n = 1000000;
    int[] a = new int[n];
    boolean builtin = false;
    for (int i = 0; i < args.length; i++) {
      if ("builtin".equals(args[i])) {
        builtin = true;
	break;
      }
    }
    final int iter = 12;
    final int trim = 1;
    long[] elapsed = new long[iter];
    for (int i = 0; i < iter; i++) {
      elapsed[i] = run(a, n, builtin);
    }
    Arrays.sort(elapsed);
    long sum = 0;
    for (int i = trim; i < iter - trim * 2; i++) {
      sum += elapsed[i];
    }
    double mean = ((double)sum) / (iter - trim * 2);
    System.out.println(mean + " ms elapsed.");
  }

  static long run(int[] a, long seed, boolean builtin) {
    Random random = new Random(seed);
    for (int i = 0; i < a.length; i++) {
      a[i] = random.nextInt();
    }
    long begin;
    if (builtin) {
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

  static boolean isSorted(int[] array) {
    for (int i = 1; i < array.length; i++) {
      if (array[i - 1] > array[i]) {
        return false;
      }
    }
    return true;
  }
}

int firstDuplicate(int[] a) {
    for (int i = 0; i < a.Length; i++) {
        if (a[Math.Abs(a[i])-1] >= 0)
        {
            a[Math.Abs(a[i])-1] = -a[Math.Abs(a[i])-1];
        }
        else
        {
            return Math.Abs(a[i]);
        }
    }
    return -1;
}

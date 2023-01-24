namespace CleancodeKata.stage4
{
    /**
     * Make this code clean.
     */
    public class Stage4
    {
        public double Compute(double[] c, bool v, bool b)
        {
            double t = 0;
            for (var i = 0; i < c.Length; ++i)
            {
                t += c[i];
            }

            var d = Compute(c.Length, b, v);
            var d2 = d * t / 100;
            return t - d2;
        }

        public int Compute(int n, bool b1, bool b2)
        {
            var p = 0;
            if (n >= 5 && n < 10)
            {
                p += 4;
            }
            else if (n >= 10)
            {
                p += 10;
            }

            if (b1)
            {
                // black friday discount
                p += 20;
            }

            if (b2)
            {
                // vip client
                p += 5;
            }

            return p;
        }
    }
}
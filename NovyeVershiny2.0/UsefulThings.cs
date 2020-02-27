using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovyeVershiny2._0
{
    class someUsefulThings
    {
        public float[] unparse(String inp, byte tag) {
            int[] buf = unparse(inp);
            float[] outp = new float[inp.Length];
            for (int i = 0; i < buf.Length; i++) {
                outp[i] = (float) (Convert.ToDouble(buf[i]) / 100.0);
            }
            return outp;
        }
        public int[] unparse(String inp) {
            if (inp == "") {
                return null;
            }
            int i = 0;
            int count = 0;
            for(i=0; i<inp.Length;i++) {
                if (inp[i] == '-') {
                    count++;
                }
            }
            count++;
            //MessageBox.Show("" +count);
            i = 0;
            int[] output = new int[count];
            String buff = "";
            int countCounted = 0;
            for (i = 0; i < inp.Length; i++)
            {
                if (inp[i] == '-')
                {
                    output[countCounted] = Convert.ToInt32(buff);
                    buff = "";
                    countCounted++;
                }
                else
                {
                    buff += inp[i];
                }
            }
            try
            {
                output[countCounted] = Convert.ToInt32(buff);
            }
            catch(Exception e) {}
            return output;
        }

        public int sum(int[] v)
        {
            if (v != null)
            {
                int outp = 0;
                for (int i = 0; i < v.Length; i++)
                {
                    outp += v[i];
                }
                return outp;
            }
            else
            {
                return 0;
            }
        }
        public float sum(float[] v)
        {
            if (v != null)
            {
                float outp = 0;
                for (int i = 0; i < v.Length; i++)
                {
                    outp += v[i];
                }
                return outp;
            }
            else
            {
                return 0;
            }
        }
    }
}

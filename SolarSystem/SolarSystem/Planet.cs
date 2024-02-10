using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem
{
    class Planet
    {
        //Data variables
        public float xe, ye, vxe, vye,xj,yj,vxj,vyj, re,rj,rej, delt,mj,me,ms, t,beta;
        public Planet(float xe, float ye, float vxe, float vye, float xj, float yj, float vxj, float vyj)
        {
            this.xe = xe; this.ye = ye; this.vxe = vxe; this.vye = vye;
            this.xj = xj; this.yj = yj; this.vxj = vxj; this.vyj = vyj;
            delt = 0.004f;
            t = 0;
            beta = 2;
             mj =(float)( 1.9 * Math.Pow(10, 27));
             me = (float)(6.0 * Math.Pow(10, 24));
             ms = (float)(2.0 * Math.Pow(10, 30));
        }
        public void revolve()
        {

            re = (float)Math.Sqrt(xe * xe + ye * ye);
            rj = (float)Math.Sqrt(xj * xj+ yj * yj);
            rej = (float)Math.Sqrt((xe-xj) * (xe -xj)+ (ye-yj) *( ye-yj));
            vxe = vxe - 4 *(float) (Math.PI * Math.PI * xe / Math.Pow(re, beta+1))*delt-4*(float)(Math.PI*Math.PI*(mj/ms)*(xe-xj)/Math.Pow(rej,beta+1))*delt;
            vye = vye - 4 * (float)(Math.PI * Math.PI * ye / Math.Pow(re, beta + 1)) * delt-4 *(float)(Math.PI * Math.PI * (mj / ms)*(ye - yj) /Math.Pow(rej, beta + 1)) * delt;
            vxj = vxj - 4 * (float)(Math.PI * Math.PI * xj / Math.Pow(rj, beta + 1)) * delt - 4 * (float)(Math.PI * Math.PI*(me / ms)*(xj - xe)/ Math.Pow(rej, beta + 1)) * delt;
            vyj = vyj - 4 * (float)(Math.PI * Math.PI * yj / Math.Pow(rj, beta + 1)) * delt - 4 * (float)(Math.PI * Math.PI*(me/ ms)*(yj - ye) /Math.Pow(rej, beta + 1)) * delt;
            xe = xe + vxe * delt;
            ye = ye + vye * delt;
            xj = xj + vxj * delt;
            yj = yj + vyj* delt;
            t = t + delt;
        }
        public void Revolve()
        {
            re = (float)Math.Sqrt(xe * xe + ye * ye);
            vxe= vxe- 4 * (float)(Math.PI * Math.PI * xe/ Math.Pow(re,beta + 1)) * delt;
            vye= vye- 4 * (float)(Math.PI * Math.PI * ye/ Math.Pow(re,beta + 1)) * delt;
            xe= xe+ vxe* delt;
            ye = ye + vye * delt; 
            t = t + delt;
        }
    }
}

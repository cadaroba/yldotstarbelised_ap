using System;
namespace LaiendusMeetodid{
   static class TekstiMeetodid2{
      public static int ArvudeSumma(this String s){
	     string[] m=s.Split(' ');
		 int summa=0;
		 int abi=0;
		 foreach(string sona in m){
		   if(int.TryParse(sona, out abi)){
		     summa+=abi;
		   }
		 }
		 return summa;
	  }
   }

   static class ArvuMeetodid{
     public static int astmes(this int arv, int aste){
	    int abi=1;
		for(int i=1; i<=aste; i++){
		   abi*=arv;
		}
		return abi;
	 }
	 public static void Tyhjenda(this int[] m){
	    for(int i=0; i<m.Length; i++){
		  m[i]=0;
		}
	 }
   }
}
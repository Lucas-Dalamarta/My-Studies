int main()
{
	int di , me , an , dc , ds , ab , db , ta;
 	
	di=10;me=03;an=2012;
	//deletavel//
	
 	ab=an%4;
 	if(ab==0)
 	{
 		ta=366;
 		if(me==2)
 		{
 			db=29;
		 }
		 else{
		 	db=28;
		 }
	 }
	else{
		ta=365;
		db=30;
	}

	ds=db-di;
	
	switch(me)
	{
		case 1 :dc=(me*31)-ds;break;
		case 2 :dc=(me*db)-ds;break;
		case 3 :dc=(me*31)-ds;break;
		case 4 :dc=(me*30)-ds;break;
		case 5 :dc=(me*31)-ds;break;
		case 6 :dc=(me*30)-ds;break;		
		case 7 :dc=(me*31)-ds;break;
		case 8 :dc=(me*31)-ds;break;
		case 9 :dc=(me*30)-ds;break;
		case 10 :dc=(me*31)-ds;break;
		case 11 :dc=(me*30)-ds;break;
		case 12 :dc=(me*31)-ds;break;
		default : printf("Erro\n");break;
						
	}
	
	printf("%d  %d  %d",db,dc,ds);
}

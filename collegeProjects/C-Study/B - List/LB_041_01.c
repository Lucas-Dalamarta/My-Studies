int main()
{
	float pe , pv;
	int pl ;
	
	printf("Digite o peso :\n");
	scanf("%f",&pe);
	printf("Digite o planeta :\n");
	scanf("%d",&pl);
	
	switch(pl)
	{
		case 1 : pv=pe*0.37;printf("\nMERCURIO\n");break;
		case 2 : pv=pe*0.88;printf("\nVENUS\n");break;
		case 3 : pv=pe*0.38;printf("\nMARTE\n");break;
		case 4 : pv=pe*2.64;printf("\nJUPITER\n");break;
		case 5 : pv=pe*1.15;printf("\nSATURNO\n");break;
		case 6 : pv=pe*1.17;printf("\nURANO\n");break;
		
		default : printf("\nPLANETA INVALIDO\n");
		
	}
	
	printf("\n%.2f Kgs na terra sao %.2f Kgs no planeta escolhido\n ",pe,pv);
	
	return 0;
}

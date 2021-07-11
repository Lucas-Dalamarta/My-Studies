int main()
{
	float vc , vv , vd ;
	char tp;
	
	printf("Digite o tipo de produto \n\t{p}-PERECIVEL\n\t{n}-NAO PERECIVEL\n");
	scanf("%c",&tp);
	printf("Digite o valor de custo :\n");scanf("%f",&vc);	
	vv=vc+vc*0.4;
	
	switch(tp)
	{
		case 'p':
			if(vv>20)
			{
				vd=vv-vv*0.20;printf("PROMOCAO 1\n");
			}
			else
			{
				if(vv>10&&vv<=20)
				{
					vd=vv-vv*0.10;printf("PROMOCAO 2\n");
				}
				else
				{
					vd=vv-vv*0.15;printf("PROMOCAO 3\n");
				}
			}
				break;
		case 'n':{
			if(vv>50)
			{
				vd=vv-vv*0.05;printf("PROMOCAO 4\n");
			}
				}break;
		default : 
			vd=vv;
			printf("PROMOCAO 0\n");break;
	}
	printf("Valor de total : %.2f\n",vd);
	return 0;
}

int main()
{
	float la , lb , lc , sab , sac , sbc ;
	
	printf("Digite lado A :\n");
	scanf("%f",&la);
	printf("Digite lado B:\n");
	scanf("%f",&lb);
	printf("Digite lado C:\n");
	scanf("%f",&lc);
	
	sab=la+lb;
	sac=la+lc;
	sbc=lb+lc;
	
	if(la<sbc||lb<sac||lc<sab)
	{
		if(la==lb&&lb==lc)
		{
			printf("TRIANGULO EQUILATERO\n");
		}
		else
		{
			if(la==lb||lb==lc)
			{
				printf("TRIANGULO ISOSCELES\n");
			}
			else
			{
				if(la!=lb&&lb!=lc&&la!=lc)
				{
					printf("TRIANGULO ESCALENO\n");
				}
			}
		}
	}
	
	return 0;	
}

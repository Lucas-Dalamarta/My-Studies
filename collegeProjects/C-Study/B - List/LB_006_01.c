int main()
{
	float ts ;
	float th ;
	
	printf("Digite o total de segundos :\n");
	scanf("%f",&ts);
	
	if(ts>=0)
	{
		th=ts/3600;
		
		printf("Total de segundos : %.0f\n",ts);
		printf("Total de horas : %.2f\n",th);
		
	}
	else
	{
		printf("Total de segundos invalido");
	}
	
	return 0;
}

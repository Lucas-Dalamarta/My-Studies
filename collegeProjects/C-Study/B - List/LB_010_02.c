int main()
{
	float alt , p ;
	int id ;
	
	printf("Digite a idade do candidato :\n");
	scanf("%d",&id);
	printf("Digite a altura do candidato :\n");
	scanf("%f",&alt);
	printf("Digite o peso do candidato :\n");
	scanf("%f",&p);
	
	if(alt>=1.70)
	{
		if(id>=21&&id<=35)
		{
			if(p>=60&&p<=95)
			{
				printf("APTO\n");
			}
		}
	}
	
	else
	
		printf("INAPTO\n");
	
	return 0;
}

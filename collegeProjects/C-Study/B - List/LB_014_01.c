int main()
{
	int tc ;
	float vc ;
	
	printf("Digite o total de copos a serem comprados :\n");
	scanf("%d",&tc);
	
	if(tc<101)
	{
		vc=tc*0.05;
	}
	else
	{
		if(tc<500)
		{
			vc=tc*0.04;
		}
		else
		{
			vc=tc*0.035;
		}
	}
	printf("Total em $ : %.2f",vc);
	
	return 0;

}

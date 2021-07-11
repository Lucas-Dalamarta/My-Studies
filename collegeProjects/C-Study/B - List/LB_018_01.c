int main()
{
	int n1 , n2 , n3 , nm ;
	printf("Digite n1 :\n");scanf("%d",&n1);	
	printf("Digite n2 :\n");scanf("%d",&n2);	
	printf("Digite n3 :\n");scanf("%d",&n3);	
	if(n1>n2&&n1>n3)
	{
		nm=n1;
	}
	else
	{
		if(n2>n1&&n2>n3)
		{
			nm=n2;
		}
		else
		{
			nm=n3;
		}
	}
	
	printf("O maior numero e : \t%d\n");
	return 0;
}

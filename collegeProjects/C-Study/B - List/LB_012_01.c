int main()
{
	int n1 , n2 , n3 , ma , me , mn ;
	
	ma=0;
	me=0;
	mn=0;
	
	printf("Digite n1 :\n");
	scanf("%d",&n1);
	printf("Digite n2 :\n");
	scanf("%d",&n2);
	printf("Digite n3 :\n");
	scanf("%d",&n3);
	
	if(n1>n2&&n1>n3)
	{
		ma=n1;
	}
	else if((n1>n2&&n1<n3)||(n1<n2&&n1>n3))
	{
		me=n1;
	}
	else if(n1<n2&&n1<n3)
	{	
		mn=n1;
	}
	if(n2>n1&&n2>n3)
	{
		ma=n2;
	}
	else if((n2>n1&&n2<n3)||(n2<n1&&n2>n3))
	{
		me=n2;
	}
	else if(n2<n1&&n2<n3)
	{	
		mn=n2;
	}
	if(n3>n1&&n3>n2)
	{
		ma=n3;
	}
	else if((n3>n1&&n3<n2)||(n3<n1&&n3>n2))
	{
		me=n3;
	}
	else if(n3<n1&&n3<n2)
	{	
		mn=n3;
	}

	
	printf(" Maior=%d \n Medio=%d\n Menor=%d\n",ma,me,mn);
	
	return 0;
}

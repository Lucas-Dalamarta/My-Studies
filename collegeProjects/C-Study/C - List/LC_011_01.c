int main()
{
	int nm , n , c ;
	nm=0;
	
	for(c=0;c<10;c++)
	{
		printf("Digite o numero \n");scanf("%d",&n);
		if(n>nm){nm=n;}
		c=c+1;
	}
	printf("%d",nm);
	return 0;
}

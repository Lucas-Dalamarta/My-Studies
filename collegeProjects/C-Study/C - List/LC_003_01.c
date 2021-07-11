int main()
{
	int b , c , n , r;
	printf("Digite o numero :\n");scanf("%d",&n);
	if(n>=1){
		for(c=1;c<=10;c++){
			r=n*c;
			printf("\n%d x %d = %d",n,c,r);
		}
	}
	else
	{
		printf("\tERROR\n");
	}
	
	return 0;
}

int main()
{
	int c , n ;
	printf("Digite o numero:");scanf("%d",&n);
	if(n<=10){for(c=0;c<n;c++){printf("* ");}}
	else{while(c<n){printf("** ");c=c+2;}}
	return 0;
}

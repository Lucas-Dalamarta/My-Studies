int main()
{
	float vt , v ; 	int c ;
	c=0;
	vt=0;
	
	while(c<10)
	{
		printf("Digite o valor \n");scanf("%f",&v);
		vt=vt+v;
		c=c+1;	
	}
	printf("%.2f",vt);
	return 0;
}

int main()
{
	int c , f ;
	
	printf("---------Converting Celsius into Fahrenheit---------\n");
	printf("Insert Celsius value :\t");
	scanf("%d",&c);
	
	f=(1.8*c)+32;
	
	printf(" %dC Converted = %dF",c,f);
	
	return 0;
	
}

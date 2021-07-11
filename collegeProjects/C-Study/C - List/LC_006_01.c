int main()
{
	float c=0 , a=0 , vr=1 , m = 0 , n ;
	
	while(vr!=0){
		printf("Digite a nota:\n");scanf("%f",&n);
		if(n<0){a+0;c+0;vr=0;}
		else{a=a+n;c++;}
	}
	m=a/c;	
	printf("\n\t MEDIA = %.0f",m);
	return 0;
}

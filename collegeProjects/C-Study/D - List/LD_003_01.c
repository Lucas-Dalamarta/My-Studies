int main()
{
	float vp[10], vt=0 ;
	int i;	
	for(i=0;i<10;i++){
		printf("Digite o valor do produto :\n");scanf("%f",&vp[i]);
	}
	for(i=0;i<10;i++){
		vt+=vp[i];
	}
	printf("Valor total :%.2f\n",vt);
	system("pause");
}

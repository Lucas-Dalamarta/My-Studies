int main()
{
	int vp[7] , i , vt=0; ;
	
	for(i=0;i<7;i++){
		printf("Digite o numero :\n");scanf("%d",&vp[i]);
	}
	for(i=0;i<7;i++){
		vt=vt+vp[i];
	}
	
	printf("Soma total : %d \n",vt);
	system("pause");
}

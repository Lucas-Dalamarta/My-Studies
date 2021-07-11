float soma(float ni[]){
	int i ;
	float vt;
	
	for(i=0;i<7;i++){
		vt+=ni[i];
	}
	return vt;
}
int main(){
	
	float ni[7] , vat=0;
	int i ;
	
	for(i=0;i<7;i++){
		printf("Digite o valor %d : \n",i+1);
		scanf("%f",&ni[i]);
	}
	
	vat=soma(ni);
	printf("Total : %.2f",vat);
	
	return 0;
}

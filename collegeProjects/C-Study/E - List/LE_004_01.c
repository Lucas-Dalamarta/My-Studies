int soma(int ni[]){
	int vt , i ;
	
	for(i=0;i<7;i++){
		vt+=ni[i];
	}
	return vt;
}
int main(){
	
	int ni[7] , i , vat=0 ;
	
	for(i=0;i<7;i++){
		printf("Digite o valor %d : \n",i+1);
		scanf("%d",&ni[i]);
	}
	
	vat=soma(ni);
	printf("Total : %d",vat);
	
	return 0;
}

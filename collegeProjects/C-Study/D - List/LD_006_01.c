#define max 10

int main(){
	int n[max] , nm=0, i;
	
	for(i=0;i<max;i++){
		printf("Digite um numero ");	scanf("%d",&n[i]);
	}
	for(i=0;i<max;i++){
		if(n[i]>nm){nm=n[i];
		}
	}
	printf("\nNumero maior : %d",nm);
}

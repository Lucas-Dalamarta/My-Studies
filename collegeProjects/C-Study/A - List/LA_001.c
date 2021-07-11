int main()
{
	int n1 , n2 , rso , rsu , rmu , rdi ;
	printf("---------Automatic Calculator---------\n");
	printf("Insert N1 : \n");
	scanf("%d",&n1);
	printf("Insert N2 : \n");
	scanf("%d",&n2);
	
	rso=n1+n2;
	rsu=n1-n2;
	rmu=n1*n2;
	rdi=n1/n2;
	
	printf("\n\n");
	printf("%d + %d = %d \n",n1,n2,rso);
	printf("%d - %d = %d \n",n1,n2,rsu);
	printf("%d X %d = %d \n",n1,n2,rmu);
	printf("%d / %d = %d \n",n1,n2,rdi);
	
	return 0;
}

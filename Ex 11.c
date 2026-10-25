#include <stdio.h>

int main(void) (
    double salario, bonus, total;
    printf("Salário base (ex.: 1500.00): ");
    scanf("%lf", &salario);
    printf("Bonus em porcentagem: ");
    scanf("%lf", &bonus);

    if (salario bonus < 0) [
        printf("Valores inválidos.\n");
        return 0;
    }
    total salario salario bonus / 100;
    printf("Salário final: R$ %.2f\n", total);
    return 0;
}

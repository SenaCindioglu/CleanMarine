#include <stdio.h>

// Function to print pixels at subsequence points
void drawCirclePoints(int xc, int yc, int x, int y) {
    printf("%d %d\n", xc + x, yc + y);
    printf("%d %d\n", xc - x, yc + y);
    printf("%d %d\n", xc + x, yc - y);
    printf("%d %d\n", xc - x, yc - y);
    printf("%d %d\n", xc + y, yc + x);
    printf("%d %d\n", xc - y, yc + x);
    printf("%d %d\n", xc + y, yc - x);
    printf("%d %d\n", xc - y, yc - x);
}

// Function for circle-generation using Bresenham's algorithm
void circleBres(int xc, int yc, int r) {
    int x = 0, y = r;
    int d = 3 - 2 * r;
    while (y >= x) {
        drawCirclePoints(xc, yc, x, y);
        x++;
        if (d > 0) {
            y--;
            d = d + 4 * (x - y) + 10;
        } else {
            d = d + 4 * x + 6;
        }}}

int main() {
    int xc, yc, maxRadius, step;
    printf("Dairenin merkezinin x koordinatini girin: \n");
    scanf("%d", &xc);
    
    printf("Dairenin merkezinin y koordinatini girin: \n");
    scanf("%d", &yc);
    
    printf("Maksimum yaricapini girin: \n");
    scanf("%d", &maxRadius);
    
    printf("Adim boyutunu girin: \n");
    scanf("%d", &step);
    
    for (int r = step; r <= maxRadius; r += step) {
        printf("Drawing circle with radius: %d\n", r);
        circleBres(xc, yc, r);
    }

    return 0;
}

/*
 struct Point {
    int x;
    int y;
};

const int MAX_POINTS = 100;  // Maksimum nokta sayısı
Point CirclePoints[MAX_POINTS];
int pointCount = 0;

void AddCirclePoints(int xc, int yc, int x, int y) {
    if (pointCount + 8 <= MAX_POINTS) {
        CirclePoints[pointCount++] = {xc + x, yc + y};
        CirclePoints[pointCount++] = {xc - x, yc + y};
        CirclePoints[pointCount++] = {xc + x, yc - y};
        CirclePoints[pointCount++] = {xc - x, yc - y};
        CirclePoints[pointCount++] = {xc + y, yc + x};
        CirclePoints[pointCount++] = {xc - y, yc + x};
        CirclePoints[pointCount++] = {xc + y, yc - x};
        CirclePoints[pointCount++] = {xc - y, yc - x};
    }
}

void GenerateCirclePoints(int xc, int yc, int r) {
    int x = 0, y = r;
    int d = 3 - 2 * r;

    while (y >= x) {
        AddCirclePoints(xc, yc, x, y);
        x++;
        if (d > 0) {
            y--;
            d = d + 4 * (x - y) + 10;
        } else {
            d = d + 4 * x + 6;
        }
    }

    ProcessCircleCoordinates();
}

void ProcessCircleCoordinates() {
    // Distinct ve sort işlemleri için geçici diziler oluştur
    Point uniquePoints[MAX_POINTS];
    int uniqueCount = 0;

    for (int i = 0; i < pointCount; i++) {
        bool isDuplicate = false;
        for (int j = 0; j < uniqueCount; j++) {
            if (CirclePoints[i].x == uniquePoints[j].x && CirclePoints[i].y == uniquePoints[j].y) {
                isDuplicate = true;
                break;
            }
        }
        if (!isDuplicate) {
            uniquePoints[uniqueCount++] = CirclePoints[i];
        }
    }

    // Min ve max Y koordinatlarını bul
    int minY = uniquePoints[0].y;
    int maxY = uniquePoints[0].y;
    for (int i = 1; i < uniqueCount; i++) {
        if (uniquePoints[i].y < minY) {
            minY = uniquePoints[i].y;
        }
        if (uniquePoints[i].y > maxY) {
            maxY = uniquePoints[i].y;
        }
    }

    // Y koordinatlarına göre ortayı hesapla
    int midpointY = (minY + maxY) / 2;

    // Sol ve sağ yarıyı ayır
    Point leftHalf[MAX_POINTS];
    int leftCount = 0;
    Point rightHalf[MAX_POINTS];
    int rightCount = 0;

    for (int i = 0; i < uniqueCount; i++) {
        if (uniquePoints[i].x <= midpointY) {
            leftHalf[leftCount++] = uniquePoints[i];
        } else {
            rightHalf[rightCount++] = uniquePoints[i];
        }
    }

    // Sol yarıyı artan X sırasına göre sırala
    for (int i = 0; i < leftCount - 1; i++) {
        for (int j = i + 1; j < leftCount; j++) {
            if (leftHalf[i].x > leftHalf[j].x) {
                Point temp = leftHalf[i];
                leftHalf[i] = leftHalf[j];
                leftHalf[j] = temp;
            }
        }
    }

    // Sağ yarıyı azalan X sırasına göre sırala
    for (int i = 0; i < rightCount - 1; i++) {
        for (int j = i + 1; j < rightCount; j++) {
            if (rightHalf[i].x < rightHalf[j].x) {
                Point temp = rightHalf[i];
                rightHalf[i] = rightHalf[j];
                rightHalf[j] = temp;
            }
        }
    }

    // Sıralanmış dizileri birleştir
    pointCount = 0;
    for (int i = 0; i < leftCount; i++) {
        CirclePoints[pointCount++] = leftHalf[i];
    }
    for (int i = 0; i < rightCount; i++) {
        CirclePoints[pointCount++] = rightHalf[i];
    }
}

void setup() {
    Serial.begin(9600);

    int xc = 10;  // Dairenin merkezi X koordinatı
    int yc = 10;  // Dairenin merkezi Y koordinatı
    int r = 5;    // Dairenin yarıçapı

    GenerateCirclePoints(xc, yc, r);

    // Koordinatları yazdır
    for (int i = 0; i < pointCount; i++) {
        Serial.print("X: ");
        Serial.print(CirclePoints[i].x);
        Serial.print(", Y: ");
        Serial.println(CirclePoints[i].y);
    }
}

void loop() {
    // Ana program döngüsü için buraya kod ekleyin
}
*/ 
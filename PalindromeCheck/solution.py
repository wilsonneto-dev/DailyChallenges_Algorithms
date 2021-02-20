def solution(string):
    firstPointerPosition = 0;
    lastPointerPosition = len(string) -1;
    
    while firstPointerPosition < lastPointerPosition:
        if string[firstPointerPosition] != string[lastPointerPosition]:
            return False
        firstPointerPosition += 1
        lastPointerPosition -= 1
    
    return True
    
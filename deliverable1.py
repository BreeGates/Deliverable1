def get_remaining_stock(initial_stock, restock_threshold, item_name):
    while True:
        try:
            sold = int(input(f"How many {item_name} have been sold today? {initial_stock} in stock: "))
            if sold > initial_stock:
                print("Too high")
            else:
                remaining_stock = initial_stock - sold
                print(f"Remaining stock of {item_name}: {remaining_stock}")
                return remaining_stock
        except ValueError:
            print("Please enter a valid number.")

def check_restock(remaining_stock, restock_threshold, item_name):
    if remaining_stock <= restock_threshold:
        print(f"{item_name} needs to be restocked.")

def main():
    soda_initial_stock = 100
    soda_restock_threshold = 40
    chips_initial_stock = 40
    chips_restock_threshold = 20
    candy_initial_stock = 60
    candy_restock_threshold = 40

    soda_remaining_stock = get_remaining_stock(soda_initial_stock, soda_restock_threshold, "sodas")
    chips_remaining_stock = get_remaining_stock(chips_initial_stock, chips_restock_threshold, "chips")
    candy_remaining_stock = get_remaining_stock(candy_initial_stock, candy_restock_threshold, "candies")

    check_restock(soda_remaining_stock, soda_restock_threshold, "Soda")
    check_restock(chips_remaining_stock, chips_restock_threshold, "Chips")
    check_restock(candy_remaining_stock, candy_restock_threshold, "Candy")


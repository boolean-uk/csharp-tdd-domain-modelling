# Domain Models
```
As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.
```
<table>
	<tr>
		<th>Classes</th>
		<th>Methods</th>
		<th>Scenario</th>
		<th>Outputs</th>
	</tr>
	<tr>
		<td><code>Customer</code></td>
		<td><code>Pay(List&ltProduct> products)</code></td>
		<td>Pay for products in basket</td>
		<td>void</td>
	</tr>
		<tr>
		<td></td>
		<td><code>Basket</code></td>
		<td>Get total cost of items</td>
		<td>float</td>
	</tr>
	</tr>
		<td><code>Product</code></td>
		<td><code>Price</code></td>
		<td>Get price of item</td>
		<td>float</td>
	</tr>
</table>

```
As an organised individual,
So that I can evaluate my shopping habits,
I'd like to see an itemised receipt that includes the name and price of the products
I bought as well as the quantity, and a total cost of my basket.
```
<table>
	<tr>
		<th>Classes</th>
		<th>Methods</th>
		<th>Scenario</th>
		<th>Outputs</th>
	</tr>
	<tr>
		<td><code>Person</code></td>
		<td><code>Receipts</code></td>
		<td>Get all of the persons receipts</td>
		<td>List&ltReceipt></td>
	</tr>
	<tr>
		<td><code>Receipt</code></td>
		<td><code>View(List&ltProduct> products)</code></td>
		<td>View the name and price of bought products</td>
		<td>List&ltstring, float></td>
	</tr>
	<tr>
		<td></td>
		<td><code>Quantity(List&ltProduct> products)</code></td>
		<td>Get the amount of products on the receipt</td>
		<td>int</td>
	</tr>
	<tr>
		<td></td>
		<td><code>TotalCost(List&ltProduct> products)</code></td>
		<td>Get the total cost of all products</td>
		<td>float</td>
	</tr>
	<tr>
		<td><code>Product</code></td>
		<td><code>Price</code></td>
		<td>Get the price of the product</td>
		<td>float</td>
	</tr>
	<tr>
		<td></td>
		<td><code>Name</code></td>
		<td>Get the name of the product</td>
		<td>string</td>
	</tr>
</table>

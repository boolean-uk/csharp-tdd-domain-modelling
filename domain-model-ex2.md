# Domain Model
```
As a supermarket shopper,
So that I can restock my cupboards,
I want to add products into my basket.

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
		<td><code>Shopper</code></td>
		<td><code>Restock(ICollection&ltProduct> products)</code></td>
		<td>Insert products into cupboard</td>
		<td>void</td>
	</tr>
	<tr>
		<td></td>
		<td><code>Add(Product product)</code></td>
		<td>Add a product to the basket</td>
		<td>void</td>
	</tr>
	<tr>
		<td></td>
		<td><code>Pay()</code></td>
		<td>Pay for all products at checkout</td>
		<td>void</td>
	</tr>
	<tr>
		<td></td>
		<td><code>Total()</code></td>
		<td>Get total cost of all products in basket</td>
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
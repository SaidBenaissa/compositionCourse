# Composition this just basics before attacking SOLID COURSES

- Direct injection (Tightly coupled):

  ```mermaid
  graph TD
      A[Car] -->|Direct Injection| B[Engine]
  ```

- Constructor injection (Loosely coupled):

  ```mermaid
  graph TD
      A[Car] -->|Constructor Injection| B[Engine]
  ```

- Property injection (set accessor must be public for property injection to work):

  ```mermaid
  graph TD
      A[Car] -->|Property Injection| B[Engine]
  ```

## Next courses : Interface-Based Composition (Best Practice)
  ```mermaid
  graph TD
      A[Car] -->|Interface-Based Composition| B[Engine]
      B --> C[Diesel Engine]
      B --> D[Petrol Engine]
      B --> E[Electric Engine]
      B --> F[Hydrogen Engine]
  ```



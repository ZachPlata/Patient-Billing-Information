---
trigger: always_on
---

# Coding Rules & Guidelines

Determining whether code is AI-generated relies on reading code patterns, evaluating logic, and understanding the limitations of automated detection tools. [[1](https://diatomenterprises.com/blog/how-to-tell-if-code-is-ai-generated/)]

Use the following rules to avoid common AI-generated code pitfalls and keep code idiomatic, domain-accurate, and maintainable.

## Rules

1. **Avoid Overly Generic or Redundant Comments**
   - Do not add excessive, obvious comment lines (e.g., `# Loop through the list to find the item`) that restate what the code already expresses. Reserve comments for explaining *why* a non-obvious decision was made. [[1](https://www.youtube.com/watch?v=kxTs-X72iXw&t=1), [2](https://diatomenterprises.com/blog/how-to-tell-if-code-is-ai-generated/)]

2. **Verify Logic and Domain Rules, Not Just Syntax**
   - Do not settle for code that merely looks clean and well-formatted on the surface. Explicitly check for subtle edge cases, surrounding context, and domain-specific business rules. [[1](https://www.youtube.com/watch?v=kxTs-X72iXw&t=1), [2](https://diatomenterprises.com/blog/how-to-tell-if-code-is-ai-generated/)]

3. **Use Specific, Domain-Driven Naming Conventions**
   - Avoid bland, vague, or overly textbook-like variable and function names (such as `data`, `item`, or `processData`). Name symbols to accurately reflect the specific project domain. [[1](https://www.youtube.com/watch?v=kxTs-X72iXw&t=1)]

4. **Include Real-World Error Handling and Resource Cleanup**
   - Do not omit robust `try`/`catch` blocks, proper logging, timeout handling, or cleanup routines for real-world failure modes such as missing files, invalid state, or network/database drops. [[1](https://www.youtube.com/watch?v=kxTs-X72iXw&t=1)]

5. **Never Use Unverified or "Hallucinated" Methods**
   - Verify that every library, API, and method called actually exists and behaves as expected in the exact framework and version used by the project—do not assume methods from other languages or frameworks exist. [[1](https://www.youtube.com/watch?v=665cZsowpn8), [2](https://diatomenterprises.com/blog/how-to-tell-if-code-is-ai-generated/)]

6. **Follow Established Project Style and Architectural Conventions**
   - Match the codebase's existing conventions, idioms, and architectural trade-offs rather than writing uniform, generic "template"-style code. [[1](https://www.reddit.com/r/learnpython/comments/10o413v/is_it_possible_to_detect_if_a_code_is_written_by/), [2](https://diatomenterprises.com/blog/how-to-tell-if-code-is-ai-generated/)]
